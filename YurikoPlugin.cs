using BepInEx;
using HarmonyLib;

namespace DSPYurikoPlugin
{
  [BepInPlugin("cc.acceyuriko.dsp", "YurikoPlugin", "1.0")]
  public class YurikoPlugin : BaseUnityPlugin
  {
    public void Start()
    {
      Harmony.CreateAndPatchAll(typeof(AssemblerComponentPatch));
      Harmony.CreateAndPatchAll(typeof(CargoPathPatch));
      Harmony.CreateAndPatchAll(typeof(DysonNodePatch));
      Harmony.CreateAndPatchAll(typeof(EjectorComponentPatch));
      Harmony.CreateAndPatchAll(typeof(FactorySystemPatch));
      Harmony.CreateAndPatchAll(typeof(FractionateComponentPatch));
      Harmony.CreateAndPatchAll(typeof(GameAbnormalityCheckPatch));
      Harmony.CreateAndPatchAll(typeof(GameHistoryDataPatch));
      Harmony.CreateAndPatchAll(typeof(GameMainPatch));
      Harmony.CreateAndPatchAll(typeof(InserterComponentPatch));
      Harmony.CreateAndPatchAll(typeof(LabComponentPatch));
      Harmony.CreateAndPatchAll(typeof(MechaPatch));
      Harmony.CreateAndPatchAll(typeof(ModelProtoPatch));
      Harmony.CreateAndPatchAll(typeof(PowerGeneratorComponentPatch));
      Harmony.CreateAndPatchAll(typeof(SiloComponentPatch));
      Harmony.CreateAndPatchAll(typeof(StarGenPatch));
      Harmony.CreateAndPatchAll(typeof(StationComponentPatch));
      Harmony.CreateAndPatchAll(typeof(StorageComponentPatch));
      Harmony.CreateAndPatchAll(typeof(UniverseGenPatch));
    }
  }
}
